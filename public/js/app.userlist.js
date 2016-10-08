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
        self.days = ['M','Tu','W','Th','F','S'];
        self.hours = [];
        for (var i=9; i<=21; i++) {
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
            if (!self.user.open) {
                self.user.open = [[],[],[],[],[],[],[]];
            }
            self.activeText = data.active ? 'Enabled' : 'Disabled';
        });
      },
      save: function() {
        this.userService.set(this.id, this.user);
      },
      start: function(d, h, ev) {
        ev.preventDefault();
        this.setting = true;
        this.set_value = !this.user.open[d][h];
        this.user.open[d][h] = this.set_value;
      },
      touchMove: function(ev) {
        var t = ev.changedTouches[0];
        var el = document.elementFromPoint(t.pageX, t.pageY);
        if (el.dataset.d !== undefined) {
            this.user.open[el.dataset.d][el.dataset.h] = this.set_value;
        }
      },
      toggle: function(d, h, ev) {
        if (ev.buttons & 1 && this.setting) {
            this.user.open[d][h] = this.set_value;
        }
        return false;
      },
      stop: function() {
        this.setting = false;
      },
      toggleActive: function(){
        this.user.active = !this.user.active;
        this.activeText = this.user.active ? 'Enabled' : 'Disabled';
      }
    });
})(window.app || (window.app = {}));
