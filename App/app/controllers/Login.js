app.controller("Login",function($scope,$http,$location){
    $scope.Login=function(){
      $http.post("https://localhost:44327/api/login",$scope.data)
      .then(function(resp){
        console.log(resp.data)
         
       // delete $sessionStorage.username;
      localStorage.setItem("token",resp.data.AccessToken);
       localStorage.setItem("UserID",resp.data.UserID);
       
        
        
    //  $sessionStorage.username= AllData.Username;


        
         $location.path("/Home")


  
      },function(err){


        console.log(err)
        $scope.error= "Invalid Login";
    });
     
  };
  
  });
  