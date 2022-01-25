app.controller("GetFlatBAR",function($scope,$http, $location){
    $http.get("https://localhost:44327/api/flats/BAR")
    .then(function(resp){


        $scope.GetFlatBAR = resp.data;
        $location.path("/GetFlatBAR")


        $scope.GetFlatBAR
  // $scope.username= $sessionStorage.username;
    },function(err){
        console.log(err);
        

    });
});