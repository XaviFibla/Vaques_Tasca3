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
}
