app.controller("GetFlatDHK",function($scope,$http, $location){
    $http.get("https://localhost:44327/api/flats/DHK")
    .then(function(resp){


        $scope.GetFlatDHK = resp.data;
        $location.path("/GetFlatDHK")

        $scope.GetFlatDHK
       
  // $scope.username= $sessionStorage.username;
    },function(err){
        console.log(err);
        

    });
});