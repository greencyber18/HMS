app.controller("GetFlatCLL",function($scope,$http, $location){
    $http.get("https://localhost:44327/api/flats/CLL")
    .then(function(resp){


        $scope.GetFlatCLL = resp.data;
        $location.path("/GetFlatCLL")


        $scope.GetFlatCLL
  // $scope.username= $sessionStorage.username;
    },function(err){
        console.log(err);
        

    });
});