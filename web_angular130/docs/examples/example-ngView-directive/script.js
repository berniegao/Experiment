  angular.module('ngViewExample', ['ngRoute', 'ngAnimate'])
    .config(['$routeProvider', '$locationProvider',
      function ($routeProvider, $locationProvider) {
        $routeProvider
          .when('/Book/:bookId', {
            templateUrl: 'book.html',
            controller: 'BookCtrl',
            controllerAs: 'book'
          })
          .when('/Book/:bookId/ch/:chapterId', {
            templateUrl: 'chapter.html',
            controller: 'ChapterCtrl',
            controllerAs: 'chapter'
          });

          // configure html5 to get links working on jsfiddle
        $locationProvider.hashPrefix('!');
        $locationProvider.html5Mode(true);
    }])
    .controller('MainCtrl', ['$route', '$routeParams', '$location',
      function($route, $routeParams, $location) {
        this.$route = $route;
        this.$location = $location;
        this.$routeParams = $routeParams;
        //$location.url('Book/Gatsby/ch/4?key=value');

    }])
    .controller('BookCtrl', ['$routeParams', function($routeParams) {
      this.name = "BookCtrl";
      this.params = $routeParams;
    }])
    .controller('ChapterCtrl', ['$routeParams', function($routeParams) {
      this.name = "ChapterCtrl";
      this.params = $routeParams;
    }]);