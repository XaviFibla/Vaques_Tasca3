pipeline {
    agent any
    stages {
        stage("test"){
            steps {
                echo "Testing..."
                dir("Vaques.Tests") {
                    sh "dotnet test"
                }
            } 
        }
    }
}