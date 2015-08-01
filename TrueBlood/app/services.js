app.factory('PatientService', ['$http',function($http) {
        return {
            all: function(){
                return $http.get('api/solicitacao/listar')
                    .success(function(data){
                       return data;
                })
            }
        }
    }])