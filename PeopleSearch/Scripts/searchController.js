(function () {
    
    var app = angular.module("searchApp", []);
   
    app.controller('searchController', function ($scope, $http) {

        var onSearchComplete = function (response) {
            $scope.results = response.data;
            $scope.loading = false;
        };

        var onError = function (response) {
            $scope.error = "No results found";
        };

        $scope.searchName = function (input) {
            $scope.loading = true;
            $scope.results = null;
            $http.get("/api/search?q=" + input)
                 .then(onSearchComplete, onError);
        };
    });

 
})();