var app = angular.module('donateBlood', ['ngRoute','ngResource'])

    .config(['$routeProvider', function($routeProvider){

        $routeProvider.when('/', {
            controller: 'PatientListCtrl'
        })

        .when('/doar/',{
            templateUrl:'app/template/donate/list.html',
                controller: 'PatientListCtrl'
        })

        .when('/donate/:id/edit',{
            templateUrl:'Edit.html',
            controller: 'PatientDetailCtrl'
        })

        .when('/solicitar',{
            templateUrl:'app/template/request/form.html',
            controller: 'PatientNewCtrl'
        })

        .otherwise({redirectTo:'/'});
    }]);