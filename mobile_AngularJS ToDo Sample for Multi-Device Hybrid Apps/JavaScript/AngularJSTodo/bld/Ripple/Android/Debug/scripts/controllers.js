(function () {
    'use strict';
    angular.module("xPlat.controllers")
        .controller('ToDoCtrl', ['$scope', 'maps', 'storage', function ($scope, maps, storage) {
            var refresh = function() {
                $scope.todos = storage.getAll();
            }

            var getAddress = function() {
                return maps.getCurrentPosition()
                    .then(maps.getAddressFromPosition, function(error) { return error.message; });
            }

            $scope.addToDo = function () {
                var text = $scope.newToDoText;
                if (!text) {
                    return;
                };

                $scope.newToDoText = '';
                getAddress().then(
                    function (address) { return storage.create(text, address); },
                    function (errorMessage) { return storage.create(text, errorMessage); })
                .then(function (todo) {
                    $scope.todos.push(todo);
                });
            }

            $scope.changeToDoText = function (toDoItem) {
                getAddress().then(function(address) {
                    toDoItem.address = address;
                    return storage.update(toDoItem);
                }, function(errorMessage) {
                    toDoItem.address = errorMessage;
                    return storage.update(toDoItem);
                });
            }

            $scope.toggleToDoDone = function (toDoItem) {
                toDoItem.done = !toDoItem.done;
                storage.update(toDoItem);
            }

            $scope.removeToDo = function(toDoItem) {
                storage.del(toDoItem).then(function (todo) {
                    var index = $scope.todos.indexOf(todo);
                    $scope.todos.splice(index, 1);
                });
            }
            refresh();
        }]);
})();