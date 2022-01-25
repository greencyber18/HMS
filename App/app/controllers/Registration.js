app.controller('Registration',function($scope,ajax)
{
    $scope.submit=function(){
        var data={
          
            Username: $scope.Username,
            Email: $scope.Email,
            Password : $scope.Password,
            Phone: $scope.Phone,
            Address : $scope.Address

        };
        //console.log(data);
        ajax.post("https://localhost:44327/api/users/create", data, success, error);

        function success(res){
           
        alert("Registration Done");
         $location.path("/Login")
        }
        function error(res){
            console.log(res);
        }
    };

});