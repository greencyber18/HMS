/* app.controller("ViewDetails",function($scope,ajax,$location,$routeParams,$http){



    //Get The specific data
    var id= $routeParams.id;
   /* ajax.get("https://localhost:44327/api/flats/GetbyID/" +id,
    
    function (response){
    $scope.Flats=response.data;
    console.log(response.data);
    },
    function (error){
    
    }
    );
    
    
    });

    $http.get("https: //localhost:44327/api/flats/GetbyID/" +id)
    .then(function(resp){
        $scope.Flats = resp.data;
        console.log(resp.data);
    },function(err){
        console.log(err);
        

    });

});
*/

app.controller("ViewDetails",function($routeParams,$scope,$http){


    $scope.Uid= localStorage.getItem("UserID")


    var id= $routeParams.id;
    $http.get("https://localhost:44327/api/flats/GetbyID/" +id)
    .then(function(resp){
        $scope.Flats = resp.data;
        console.log(resp.data);
    },function(err){
        console.log(err);
        

    });
});

