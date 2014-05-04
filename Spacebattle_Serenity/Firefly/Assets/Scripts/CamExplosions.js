 var ObjectToInstantiate : GameObject;

    var ObjectToPlotOnGrid : GameObject[];

    var pointThatHasBeenTaken : Vector2[];

    

    

        for(var i=0;i<20;i++) {

            ObjectToPlotOnGrid[i] = Instantiate(ObjectToInstantiate);

            ObjectToPlotOnGrid[i].transform.position.x = Screen.width/20*Random.Range(0,20);

            ObjectToPlotOnGrid[i].transform.position.y = Screen.width/20*Random.Range(0,20);

            pointThatHasBeenTaken[i]= Vector2(ObjectToPlotOnGrid[i].transform.position.x, ObjectToPlotOnGrid[i].transform.position.y);

            

            for(var ii = 0; ii < i; ii++) {

                if(Vector2(ObjectToPlotOnGrid[i].transform.position.x,ObjectToPlotOnGrid[i].transform.position.y ) == pointThatHasBeenTaken[ii]) {

                    print("Rerolling spawn");

                    ObjectToPlotOnGrid[i].transform.position.x = Screen.width/20*Random.Range(0,20);

                    ObjectToPlotOnGrid[i].transform.position.y = Screen.width/20*Random.Range(0,20);

                    ii--;

                }

            }

        }