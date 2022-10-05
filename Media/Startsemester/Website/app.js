var select_experience = document.getElementById('form_experience');
var select_frequency = document.getElementById('form_frequency');
var select_volume = document.getElementById('form_volume');

var download;


function buttonClick(){
    var value_experience = select_experience.value
    var value_frequency = select_frequency.value
    var value_volume = select_volume.value
    var file = "test.txt"

    var query = [];
    var query_experience = [];
    var query_frequency = [];
    var query_volume = [];
    

    switch(value_experience) {
        case '1':
          // code block
          query_experience.push("Beginner")
          break;
        case '2':
          // code block
          query_experience.push("Intermediate")
          break;
        case '3':
        // code block
        query_experience.push("Elite")
        break;
        default:
          // code block
          console.log("Select experience")
      }

    switch(value_frequency) {
        case '1':
          // code block
          query_frequency.push("1");
          break;
        case '2':
          // code block
          query_frequency.push("2");
          break;
        case '3':
          // code block
          query_frequency.push("3");
        break;
        case '4':
          // code block
          query_frequency.push("4");
          break;
        case '5':
          // code block
          query_frequency.push("5");
          break;
        case '6':
          // code block
          query_frequency.push("6");
          break;
        case '7':
          // code block
          query_frequency.push("7");
        break;
        default:
          // code block
          console.log("Select Frequency");
      }

    switch(value_volume) {
        case '1':
          // code block
          query_volume.push("Low")
          console.log("button has been pressed")
          query = query_experience.concat(query_frequency, query_volume);
          download = query[0] + "_" + query[1] + "_" + query [2];
          downloadProgram(download)
          break;
        case '2':
          // code block
          query_volume.push("Normal")
          console.log("button has been pressed")
          query = query_experience.concat(query_frequency, query_volume);
          download = query[0] + "_" + query[1] + "_" + query [2];
          downloadProgram(download)
          break;
        case '3':
        // code block
        query_volume.push("High")
        console.log("button has been pressed")
          query = query_experience.concat(query_frequency, query_volume);
          download = query[0] + "_" + query[1] + "_" + query [2];
          downloadProgram(download)
        break;
        default:
          // code block
          console.log("Select Volume")
      }

      
      
      function downloadProgram(download) {
        var link = document.getElementById("button");
        var downloadLink = "programs/" + download + ".txt"

        console.log("download is: ", download)
        console.log("Download link is: " + downloadLink)
        link.getAttribute("href");
        link.setAttribute("href", downloadLink);
        console.log(link.getAttribute("href"))
      }

      
};
