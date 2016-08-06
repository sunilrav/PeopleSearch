(function () {
    
    var app = angular.module("searchApp", []);
   
    app.controller('searchController', function ($scope, $http) {

        var onSearchComplete = function (response) {
            $scope.results = response.data;
            if ($scope.results.length == 0)
            {
                $scope.noresults = "Could not find any contact with that name.";
            }
            $scope.loading = false;
        };

        var onError = function (response) {
            $scope.error = "System not avaliable at this time.(Exception)";
        };

        $scope.searchName = function (input) {
            $scope.loading = true;
            $scope.results = null;
            $scope.noresults = null;
            $scope.error = null;
            $http.get("/api/search?q=" + input)
                 .then(onSearchComplete, onError);
        };
    });

 
})();