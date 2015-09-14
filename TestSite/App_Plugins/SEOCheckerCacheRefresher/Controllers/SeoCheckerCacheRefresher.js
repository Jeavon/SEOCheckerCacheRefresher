angular.module("umbraco").controller("SeoCheckerCacheRefresher", function ($scope, $http) {

    $scope.clearCache = function() {
        var dataUrl = "/Umbraco/BackOffice/SeoCheckerCacheRefresher/SeoCheckerCache/RefreshAll";
        // Ajax request to controller for data-
        $http.get(dataUrl).success(function (data) {
            if (data === "true") {
                $scope.clearStatus = true;
            }
        });
    }
});