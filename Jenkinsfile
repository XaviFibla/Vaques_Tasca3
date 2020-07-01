pipeline {
    agent any
    stages{
        stage("test"){
            steps{
                echo "Test..."
                dir(Vaques.Tests) dotnet test
            } 
        }
    }
}