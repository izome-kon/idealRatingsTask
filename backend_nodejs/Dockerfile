FROM node:23

RUN apt-get update && apt-get install -y
# Create app directory
WORKDIR /app

# Install app dependencies
COPY package*.json ./

RUN npm install

# install typescript
RUN npm install -g typescript
RUN npm install -g ts-node
RUN npm install -g ts-node-dev

# Bundle app source
COPY . .

# Expose the port the app runs on
EXPOSE 3000
# Start the app
CMD [ "npm", "run", "dev" ]