(function () {
    
    var app = angular.module("searchApp", []);
   
    app.controller('searchController', function ($http, $scope) {

        var vm = this;

        onSearchComplete = function (response) {
            vm.results = response.data;
            if (vm.results.length == 0)
            {
                vm.noresults = "Could not find any contact with that name.";
            }
            vm.loading = false;
        };

        onError = function (response) {
            vm.error = "System not avaliable at this time.(Exception)";
        };

        this.searchName = function (input) {
            vm.loading = true;
            vm.results = null;
            vm.noresults = null;
            vm.error = null;
            $http.get("/api/search?q=" + input)
                 .then(onSearchComplete, onError);
        };
    });

 
})();