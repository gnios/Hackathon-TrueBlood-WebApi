app.factory('PatientService', ['$http',function($http) {
        return {
            all: function(){
                return $http.get('http://donateblood.dev/fake.json')
                    .success(function(data){
                       return data;
                })
            }
        }
    }])