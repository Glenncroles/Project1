Note: 
* If any step that perform unsuccessfully due to permission error, start the line with sudo   
* Default name is my-app-instance. You can change this but I recomnend not to for simplicicy.
* If everything is executed successfully, you will have another VM instance that contain the run the server. 
Use this instance external ip to access to the website .
* Deploying may take some minutes
### Step1: Create VM instant
* Give it a name   
* Using ubuntu 16   
* Tick "Allow full access to all Cloud APIs" radio button   
* Check "Allow HTTP traffic" checkbox   

### Step2 :Create bucket
* On Google Cloud Platform, enter bucket on searchbar and click on Storage  
* Click on Bucket and give it a name (You will need this name later). After that, click Create      

### Step3: Install java and maven to your VM instant
* Update necessary components:

        sudo apt-get update -y && sudo apt-get upgrade -y
        
* Install java and set JAVA_HOME (Hit Y/Enter when asked) (https://tecadmin.net/install-openjdk-java-ubuntu/)   

        sudo apt-get install openjdk-8-jre openjdk-8-jdk
        sudo nano /etc/environment
        Write "JAVA_HOME=/usr/lib/jvm/java-8-openjdk-amd64/" into the file and save it (Path maybe different)
        
        source etc/environment
* Install maven (Hit Y/Enter when asked) (https://howtoprogram.xyz/2016/09/08/install-maven-ubuntu-16-04-lts-xenial-xerus/)   

        sudo apt-get install maven

### Step4: Tweak and Deloy:
* Clone and go into the right folder   

        git clone https://github.com/Glenncroles/Project1
        cd Project1/gce
        
* Refine the `makeProject` script   

        nano makeProject
        
        Enter/change your `BUCKET`, `REGION`, and `Zone` (This group is assignmed to asia-northeast-b
 
        EX: 
                BUCKET= bucketthatwascreatedinstep2

                REGION=asia-northeast
                ZONE=$REGION-b

For the sake of simplicity, we will keep everything else the same  

* Deploy your App

        sudo ./makeProject gce

* To tear down the App, use

        sudo ./makeProject down
       

