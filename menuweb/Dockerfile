FROM node:lts-alpine

# install simple http server
RUN npm install -g http-server

# make app directory as a working directory
WORKDIR /app

# copy package json and package.lock.json
COPY package*.json ./

# install npm packages
RUN npm install

# build production build
RUN npm run build

EXPOSE 8080
CMD [ "http-server", "dist" ]