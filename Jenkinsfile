pipeline {
    agent any
    stages {
        stage ('compilar') {
            steps {
                echo "Compilant..."
                dir("Vaques.Tests") {
                    bat "dotnet build"
                }
            }
        }
        stage('test') {
            steps {
                echo "Testing..."                
                dir("Vaques.Tests") {
                    bat "dotnet test"
                }
            }
        }
    }
     post {
       // only triggered when blue or green sign
       success {
           slackSend (color: '#00FF00', message: "SUCCESSFUL: Job")
       }
       // triggered when red sign
       failure {
             slackSend (color: '#FF0000', message: "FAILED: Job")
       } 
    }
}
