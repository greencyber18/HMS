/* app.controller('AddBooking',function($scope,$http)
{
    
    $scope.addBooking=function(){
        $http.post("https://localhost:44327/api/Bookings/Add", data, success, error);

        //console.log(data);

        function success(res){
           
        alert("Add Done");
         
        }
        function error(res){
            console.log(res);
        }
    };

}); */

app.controller("AddBooking",function($scope,ajax,$location){

  

    // Perform Add
    $scope.addBooking = function (){
 
     ajax.post("https://localhost:44327/api/Bookings/Add",$scope.Flats,
       
     function (response){
       $location.path("/Booking");
     },
     function (error){
 
     });
 
    }
  
 
 });