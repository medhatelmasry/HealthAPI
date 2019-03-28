generateomd /source=. /output=diagram
generateomd /source=. /output=test /format=md
generateomd /source=. /output=diagram /exclude="*/bin/*;*/tests/*;*/Views/*;*/Areas/*"
generateomd /output=difs /source=https://github.com/medhatelmasry/HealthAPI/archive/ver2.zip /compareSource=https://github.com/medhatelmasry/HealthAPI/archive/master.zip /exclude="*/ref/*;*/tests/*;*/perftests/*"
