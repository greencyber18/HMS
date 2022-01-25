var app = angular.module("myApp", ["ngRoute"]);

app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })
    
    
    .when("/Booking", {
        templateUrl : "views/pages/Booking.html",
        controller: 'AddBooking'
    })

    .when("/Login", {
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })
    .when("/Registration", {
        templateUrl : "views/pages/Registration.html",
        controller: 'Registration'
    })
    .when("/AddBooking", {
        templateUrl : "views/pages/ViewDetails.html",
        controller: 'AddBooking'
    })
    .when("/Flats", {
        templateUrl : "views/pages/Flats.html",
        controller: 'Flats'
    })

    .when("/Logout", {
        templateUrl : "views/pages/Login.html",
        controller: 'Logout'
    })

    .when("/Home", {
        templateUrl : "views/pages/Home.html",
        controller: 'Home'
    })

    .when("/ViewDetails/:id", {
        templateUrl : "views/pages/ViewDetails.html",
        controller: 'ViewDetails'
    })
    .when("/Contact", {
        templateUrl : "views/pages/Contact.html",
        controller: 'Contact'
    })
    .when("/Booking", {
        templateUrl : "views/pages/Booking.html",
        controller: 'Booking'
    })

    .when("/GetFlatBAR", {
        templateUrl : "views/pages/GetFlatBAR.html",
        controller: 'GetFlatBAR'
    })
    .when("/GetFlatCLL", {
        templateUrl : "views/pages/GetFlatCLL.html",
        controller: 'GetFlatCLL'
    })
    .when("/GetFlatDHK", {
        templateUrl : "views/pages/GetFlatDHK.html",
        controller: 'GetFlatDHK'
    })
    .when("/GetFlatSYL", {
        templateUrl : "views/pages/GetFlatSYL.html",
        controller: 'GetFlatSYL'
    })

    .when("/GetFlatCTG", {
        templateUrl : "views/pages/GetFlatCTG.html",
        controller: 'GetFlatCTG'
    })
    .when("/Profile", {
        templateUrl : "views/pages/Profile.html",
        controller: 'Profile'
    })
    .when("/Properties", {
        templateUrl : "views/pages/Properties.html",
        controller: 'Properties'
    })

    
    .otherwise({
        redirectTo:"/Home"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
app.config(function($httpProvider){
    $httpProvider.interceptors.push('interceptor');
})