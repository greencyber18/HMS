app.controller("Logout",function($http){
    //localStorage.removeItem('token');
    //include ajax in dependency
    //ajax.get("api/logout",function(resp){},function(err){});
    
    $http.get("https://localhost:44327/api/logout")
    .then(function(rsp){
        localStorage.removeItem("token");
        localStorage.removeItem("UserID");
        $location.path("/Login")
    },function(err){
        console.log(err);
    });

});