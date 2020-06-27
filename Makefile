IMG_NAME=covid-api
CONT_NAME=covid-api
HEROKU_APP=unibh-covid-api

dev_build:
	docker image rm --force $(IMG_NAME)
	docker build -t $(IMG_NAME) ./Covid-API

dev_run:
	docker container rm $(CONT_NAME)
	docker run -p 8080:80 --name $(CONT_NAME) $(IMG_NAME)

heroku_push:
	cd ./Covid-API && \
	heroku container:push web -a $(HEROKU_APP) && \
	cd ..

heroku_release:
	cd ./Covid-API && \
	heroku container:release web -a $(HEROKU_APP) && \
	cd ..