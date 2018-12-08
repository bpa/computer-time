(function(app) {
  app.Module =
    ng.core.NgModule({
      imports: [
        ng.platformBrowser.BrowserModule,
        ng.http.HttpModule,
      ],
      declarations: [ app.UserList ],
      bootstrap: [ app.UserList ]
    })
    .Class({
      constructor: function() {}
    });
})(window.app || (window.app = {}));
