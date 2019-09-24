

### Running Locally

    mvn clean jetty:run-exploded -DprojectID=YOUR-PROJECT-ID

### Deploying to Compute Engine

* Initialize the [Google Cloud SDK][cloud_sdk]

        gcloud init

* In the `makeProject` script update the `BUCKET` and region

* Deploy your App

        ./makeProject gce

* To tear down the App, use

        ./makeProject down
        
### Deploying to Compute Engine with horizontal scaling

* Initialize Google Cloud SDK and `makeProject` as above.

* Deploy your App

        ./makeProject gce-many

* To tear down the App, use

        ./makeProject down-many

[cloud_sdk]: https://cloud.google.com/sdk/
