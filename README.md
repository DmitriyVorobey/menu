# menu
Menu web site is an example of classic three layer application.

## Getting Started
To run production build locally:
- go to project directory
- run docker-compose up

To run front end with hot reload:
 - go to menuweb folder
 - run docker build -f Dockerfile.dev -t menuweb:dev  .
 - run docker run -v ${PWD}:/app -v /app/node_modules -p 8080:8080 --rm menuweb:dev
 
 ### Prerequisites
 Docker for windows should be installed https://docs.docker.com/docker-for-windows/ for windows pc.
 Docker for mac should be installed https://docs.docker.com/docker-for-mac/install/ for mac pc.

