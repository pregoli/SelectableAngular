"use strict";
(function () {
    angular.module("myApp")
           .controller("clientCtrl", ["$scope", "clientService",
                function ($scope, clientService) {

                    $scope.testPersistency = function () {
                        debugger;
                        var test = $scope.clients;
                    };

                    $scope.onCheck = function onCheck(client) {
                        if (client.Selected) {

                            debugger;
                            clientDropdowns(client.Id);

                            console.log("client" + client.Id + " is selected!");
                        } else {
                            console.log("client" + client.Id + " is NOT selected!");
                        }
                    };

                    var clientDropdowns = function (clientId) {
                        clientService.getClientDropDowns(clientId).then(onGetClientDropDownsCompleted, onGetClientDropDownsError);
                    };

                    var onGetClientDropDownsCompleted = function (data) {

                        debugger;

                        var clientId = data[0].ClientId;

                        
                        $scope.clients.filter(function (client) {
                            return client.Id == clientId;
                        })[0].clientDropDowns = data;
                    };

                    var onGetClientDropDownsError = function (message) {
                        $scope.error = "Error Fetching Clients. Message:" + message;
                    };

                    var getClients = function () {
                        clientService.getClients().then(onGetClientsCompleted, onGetClientsError);
                    };

                    var onGetClientsCompleted = function (data) {
                        $scope.clients = data;
                    };

                    var onGetClientsError = function (message) {
                        $scope.error = "Error Fetching Clients. Message:" + message;
                    };

                    getClients();
                }]);
})();