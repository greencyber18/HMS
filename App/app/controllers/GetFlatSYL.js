app.controller("GetFlatSYL",function($scope,$http, $location){
    $http.get("https://localhost:44327/api/flats/SYL")
    .then(function(resp){


        $scope.GetFlatSYL = resp.data;
        $location.path("/GetFlatSYL")


       
  // $scope.username= $sessionStorage.username;
    },function(err){
        console.log(err);
        

    });
});