pipeline {
    agent any
    stages {
        stage ('compilar') {
            steps {
                echo('Compilant...')
                dir('Vaques.Tests') {
                    sh 'dotnet build'
                }
            }
        }
        stage('test') {
            steps {
                echo 'Testing...'                
                dir('Vaques.Tests') {
                    sh 'dotnet test'
                }
            }
        }
    }
}
