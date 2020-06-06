docker pull azurenapratica/sitecontagem:1.0

docker pull azurenapratica/sitecontagem

docker pull azurenapratica/sitecontagem:1.1

docker run --name site01 -p 1234:80 -d azurenapratica/sitecontagem:1.0

docker run --name site02 -p 1235:80 -d azurenapratica/sitecontagem

docker run --name site03 -p 1236:80 -d azurenapratica/sitecontagem:latest

docker run --name site04 -e "MensagemVariavel=Usando variavel de ambiente" -p 1237:80 -d azurenapratica/sitecontagem:1.1

docker ps

docker container ls

docker ps -a

docker container ls -a