app.controller('EditProfile',function($scope,ajax)
{
    $scope.edit=function(){
        var data={
          
            Username= Profile.Username
           

        };
        //console.log(data);
        ajax.post("https://localhost:44327/api/users/edit", data, success, error);

        function success(res){
           
        alert("Edit Done");
         $location.path("/Profile")
        }
        function error(res){
            console.log(res);
        }
    };

});