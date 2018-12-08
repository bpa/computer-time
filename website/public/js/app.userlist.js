(function(app) {
  app.UserList =
    ng.core.Component({
      selector: 'ct-app',
      templateUrl: 'userlist.html',
      providers: [app.UserService],
    })
    .Class({
      constructor: [app.UserService, function(users) {
        this.userService = users;
        this.user = null;
      }],
      ngOnInit: function() {
        var self = this;
        self.days = ['M','Tu','W','Th','F','S','Su'];
        self.hours = [];
        for (var i=8; i<=22; i++) {
            self.hours.push(i);
        }
        self.userService.getNames().subscribe(function(data){
            self.users = data;
        });
      },
      select: function(user) {
        var self = this;
        self.id = user;
        self.userService.get(user).subscribe(function(data){
            self.user = data;
            self.activeText = data.active ? 'Enabled' : 'Disabled';
            console.log(self.user);
        });
      },
      allow: function(d, h) {
        this.user.open[d][h] = 1;
      },
      deny: function(d, h) {
        delete this.user.open[d][h];
      },
      save: function() {
        this.userService.set(this.id, this.user);
      },
      start: function(d, h, ev) {
        ev.preventDefault();
        this.set_value = this.user.open[d][h] ? this.deny : this.allow;
        this.set_value(d, h);
      },
      touchMove: function(ev) {
        var t = ev.changedTouches[0];
        var el = document.elementFromPoint(t.pageX, t.pageY);
        if (el.dataset.d !== undefined) {
            this.set_value(el.dataset.d, el.dataset.h);
        }
      },
      toggle: function(d, h, ev) {
        if (ev.buttons & 1 && this.set_value) {
            this.set_value(d, h);
        }
        return false;
      },
      stop: function() {
        this.set_value = false;
      },
      toggleActive: function(){
        this.user.active = !this.user.active;
        this.activeText = this.user.active ? 'Enabled' : 'Disabled';
      }
    });
})(window.app || (window.app = {}));
