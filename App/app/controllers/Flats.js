app.controller("Flats",function($scope,$http, $location){
    $http.get("https://localhost:44327/api/flats")
    .then(function(resp){


        $scope.Flats = resp.data;
        $location.path("/Flats")


  // $scope.username= $sessionStorage.username;
    },function(err){
        console.log(err);
        

    });
});