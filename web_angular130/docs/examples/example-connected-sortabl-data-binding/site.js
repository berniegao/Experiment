var myapp = angular.module('sortableApp', ['ui.sortable']);


myapp.controller('sortableController', function ($scope) {
    var tmpList = [];

    $scope.rawScreens = [
      [{
          icon: './img/icons/facebook.jpg',
          title: 'Facebook (a)',
          link: 'http://www.facebook.com'
      }, {
          icon: './img/icons/youtube.jpg',
          title: 'Youtube (a)',
          link: 'http://www.youtube.com'
      }, {
          icon: './img/icons/gmail.jpg',
          title: 'Gmail (a)',
          link: 'http://www.gmail.com'
      }, {
          icon: './img/icons/google+.jpg',
          title: 'Google+ (a)',
          link: 'http://plus.google.com'
      }, {
          icon: './img/icons/twitter.jpg',
          title: 'Twitter (a)',
          link: 'http://www.twitter.com'
      }, {
          icon: './img/icons/yahoomail.jpg',
          title: 'Yahoo Mail (a)',
          link: 'http://mail.yahoo.com'
      }, {
          icon: './img/icons/pinterest.jpg',
          title: 'Pinterest (a)',
          link: 'http://www.pinterest.com'
      }],
      [{
          icon: './img/icons/facebook.jpg',
          title: 'Facebook (b)',
          link: 'http://www.facebook.com'
      }, {
          icon: './img/icons/youtube.jpg',
          title: 'Youtube (b)',
          link: 'http://www.youtube.com'
      }, {
          icon: './img/icons/gmail.jpg',
          title: 'Gmail (b)',
          link: 'http://www.gmail.com'
      }, {
          icon: './img/icons/google+.jpg',
          title: 'Google+ (b)',
          link: 'http://plus.google.com'
      }, {
          icon: './img/icons/twitter.jpg',
          title: 'Twitter (b)',
          link: 'http://www.twitter.com'
      }, {
          icon: './img/icons/yahoomail.jpg',
          title: 'Yahoo Mail (b)',
          link: 'http://mail.yahoo.com'
      }, {
          icon: './img/icons/pinterest.jpg',
          title: 'Pinterest (b)',
          link: 'http://www.pinterest.com'
      }],
      [{
           icon: './img/icons/facebook.jpg',
           title: 'Facebook (c)',
           link: 'http://www.facebook.com'
       }, {
           icon: './img/icons/youtube.jpg',
           title: 'Youtube (c)',
           link: 'http://www.youtube.com'
       }, {
           icon: './img/icons/gmail.jpg',
           title: 'Gmail (c)',
           link: 'http://www.gmail.com'
       }, {
           icon: './img/icons/google+.jpg',
           title: 'Google+ (c)',
           link: 'http://plus.google.com'
       }, {
           icon: './img/icons/twitter.jpg',
           title: 'Twitter (c)',
           link: 'http://www.twitter.com'
       }, {
           icon: './img/icons/yahoomail.jpg',
           title: 'Yahoo Mail (c)',
           link: 'http://mail.yahoo.com'
       }, {
           icon: './img/icons/pinterest.jpg',
           title: 'Pinterest (c)',
           link: 'http://www.pinterest.com'
       }]
    ];


    $scope.sortingLog = [];

    function createOptions(listName) {
        var _listName = listName;
        var options = {
            placeholder: "app",
            connectWith: ".apps-container",
            activate: function () {
                console.log("list " + _listName + ": activate");
            },
            beforeStop: function () {
                console.log("list " + _listName + ": beforeStop");
            },
            change: function () {
                console.log("list " + _listName + ": change");
            },
            create: function () {
                console.log("list " + _listName + ": create");
            },
            deactivate: function () {
                console.log("list " + _listName + ": deactivate");
            },
            out: function () {
                console.log("list " + _listName + ": out");
            },
            over: function () {
                console.log("list " + _listName + ": over");
            },
            receive: function () {
                console.log("list " + _listName + ": receive");
            },
            remove: function () {
                console.log("list " + _listName + ": remove");
            },
            sort: function () {
                console.log("list " + _listName + ": sort");
            },
            start: function () {
                console.log("list " + _listName + ": start");
            },
            stop: function () {
                console.log("list " + _listName + ": stop");
            },
            update: function () {
                console.log("list " + _listName + ": update");
            }
        };
        return options;
    }

    $scope.sortableOptionsList = [createOptions('A'), createOptions('B'), createOptions('C')];

    $scope.logModels = function () {
        $scope.sortingLog = [];
        for (var i = 0; i < $scope.rawScreens.length; i++) {
            var logEntry = $scope.rawScreens[i].map(function (x) {
                return x.title;
            }).join(', ');
            logEntry = 'container ' + (i + 1) + ': ' + logEntry;
            $scope.sortingLog.push(logEntry);
        }
    };
});