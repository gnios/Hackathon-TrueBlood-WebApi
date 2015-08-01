app
// Functions to Patient
.controller('PatientListCtrl', ['PatientService', '$scope', '$location', function (PatientService, $scope, $location) {
    var self = this;
    self.pacientes = [];
    self.list = PatientService.all();
    self.list.success(function (data) {
        $.each(data, function (key, paciente) {
            self.pacientes.push(new Pacientes(paciente));
        });
        $scope.pacientes = self.pacientes;
        $scope.tipossangue = getTPSangue();
    });

    function Pacientes(paciente) {
        var self = this;
        self.id = paciente.$id;
        self.nome = paciente.Paciente.Nome;
        self.hospital = paciente.Hospital.Nome;
        self.tiposangue = getTPSangue(paciente.TipoSangue);
        return self;
    }

    $scope.doar = function (paciente) {
        $scope.pacienteSelecionado = paciente;
    }
    $scope.confirmarDoacao = function (pacienteSelecionado) {
        console.log('data', pacienteSelecionado);
    }

}])

.controller('PatientDetailCtrl', ['$scope', '$routeParams', '$location', 'PatientService', function ($scope, $routeParams, $location, PatientService) {
    $scope.action = 'update';
    $scope.update = function () {
        PatientService.update({ id: $routeParams.id }, $scope.Patient);
        $location.path('cadastre/Patient');
    };
    $scope.cancel = function () { $location.path('cadastre/Patient'); };
    $scope.Patient = PatientService.get({ id: $routeParams.id });

}])

.controller('PatientNewCtrl', ['$scope', '$location', 'PatientService', function ($scope, $location, PatientService) {
    $scope.action = 'new';
    $scope.create = function () { PatientService.save($scope.paciente); $location.path('/'); }
    $scope.tipossangue = getTPSangue();
}])

function getTPSangue(id) {
    if (!(isNaN(id))) {
        switch (id) {
            case 1: return 'A+';
            case 2: return 'A-';
            case 3: return 'B+';
            case 4: return 'B-';
            case 5: return 'AB+';
            case 6: return 'AB-';
            case 7: return 'O+';
            case 8: return 'O-';
        }
    } else {
        return [{ id: 0, name: 'A+' }, { id: 1, name: 'A-' }, { id: 2, name: 'B+' }, { id: 3, name: 'B-' }, { id: 4, name: 'B-' }, { id: 5, name: 'AB+' }, { id: 6, name: 'AB-' }, { id: 7, name: 'O+' }, { id: 8, name: 'O-' }];
    }
}
