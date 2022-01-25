app.controller('Contact',function($scope,$http)
{
    $scope.submit=function(){
        var data={
            Proj_Id: $scope.Proj_Id="",
            Name: $scope.Name,
            State: $scope.State="Open",
            Type: $scope.Type,
            Duaration: $scope.Duaration
        };
        //console.log(data);
        ajax.post("https://localhost:44322/api/Project/Create", data, success, error);

        function success(res){
            console.log("Success Operation");
        }
        function error(res){
            console.log(res);
        }
    };

});