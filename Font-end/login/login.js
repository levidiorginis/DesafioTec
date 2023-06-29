angular
  .module("loginApp", [])
  .controller("loginController", function ($scope, $http) {
    $scope.loginData = {};

    $scope.login = function () {
      var url = "https://localhost:7287/api/auth";
      var headers = {
        login: $scope.loginData.username,
        password: $scope.loginData.password,
      };

      $http
        .get(url, { headers: headers })
        .then(function (response) {
          // Requisição bem-sucedida
          if (response.status === 200) {
            // Salve o token no cookie
            document.cookie = "token=" + response.data.token + "; path=/";

            // Redirecione para a página em branco
            window.location.pathname = "usuario/usuario.html";
          } else {
            // Credenciais incorretas
            $scope.errorMessage = "Login ou senha incorretos.";
            // Remover a mensagem de erro após 5 segundos
            setTimeout(function () {
              $scope.errorMessage = "";
              $scope.$apply();
            }, 5000);
          }
        })
        .catch(function (error) {
          // Erro na requisição
          console.error("Erro na requisição:", error);
          $scope.errorMessage = "Ocorreu um erro ao fazer o login.";
          // Remover a mensagem de erro após 5 segundos
          setTimeout(function () {
            $scope.errorMessage = "";
            $scope.$apply();
          }, 5000);
        });
    };
  });
