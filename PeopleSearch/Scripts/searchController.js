(function () {
    
    var app = angular.module("searchApp", []);

    app.controller('searchController', function ($scope, $http) {

        var onSearchComplete = function (response) {
            $scope.results = response.data;
        };

        var onError = function (response) {
            $scope.error = "No results found";
        };

        $scope.searchName = function (input) {
            $http.get("http://localhost:51212/api/search?q=" + input)
                 .then(onSearchComplete, onError);
        };
    });

 
})();