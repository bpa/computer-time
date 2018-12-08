(function(app) {
  app.UserService = ng.core.Class({
    constructor:[ng.http.Http, function(http) {
        this.http = http;
        this.opts = new ng.http.RequestOptions({
            headers: new ng.http.Headers({'Content-Type': 'application/json'})
        });
    }],
    getNames: function() {
      return this.http.get('/user').map(function(res){return res.json();})
    },
    get: function(name){
      return this.http.get('/user/'+name).map(function(res){return res.json();})
    },
    set: function(name, data){
      this.http.post('/user/'+name, JSON.stringify(data), this.opts).subscribe();
    },
  })
})(window.app || (window.app = {}));
