# Docker image and container creation
## Create image on local machine 
1. Create app
2. Build an image from a Dockerfile and run below cmd(where tag 1.0 is app version)
   o	docker build: docker build -t myapp:1.0 
3. Run a container.
   o	docker run:  docker run -p 8080:8080 myapp:1.0
4. Hit the below URL to access the app from container
   http://localhost:8080/weatherforecast/

# Docker compose tool to simplify management and deployment of multiple containers
Using docker-compose.yaml, we can build and run multiple containers with network and environment config at the same time.

# Push image onto DockerHub
https://hub.docker.com/repositories/bhuvanakm
We can also push image onto Azure Container Registry(ACR) with scalibility and security
