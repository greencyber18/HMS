app.controller("Booking",function($routeParams,$scope,$http){

    test= localStorage.getItem("UserID")
    $http.get("https://localhost:44327/api/Bookings/" +test)
    .then(function(resp){
        $scope.Booking = resp.data;
        console.log(resp.data);
    },function(err){
        console.log(err);
        

    });
});
