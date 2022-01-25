app.controller("GetFlatCTG",function($scope,$http, $location){
    $http.get("https://localhost:44327/api/flats/CTG")
    .then(function(resp){


        $scope.GetFlatCTG = resp.data;
        $location.path("/GetFlatCTG")


       
  // $scope.username= $sessionStorage.username;
    },function(err){
        console.log(err);
        

    });
});