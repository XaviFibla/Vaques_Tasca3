pipeline {
    agent any
    environment {
         DOTNET_ROOT = "C:\\Program Files\\dotnet"              
    }
    stages {
        stage("test"){
            steps {
                echo "Testing..."
                dir("Vaques.Tests") {
                    sh "${DOTNET_ROOT} test"
                }
            } 
        }
    }
}