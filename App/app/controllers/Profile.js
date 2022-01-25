
app.controller("Profile",function($routeParams,$scope,$http){

    test= localStorage.getItem("UserID")
    $http.get("https://localhost:44327/api/User/GetbyID/" + test)
    .then(function(resp){
        $scope.Profile = resp.data;
        console.log(resp.data);
    },function(err){
        console.log(err);
        

    });



    
});