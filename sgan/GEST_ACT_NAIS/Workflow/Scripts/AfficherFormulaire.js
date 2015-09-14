$(document).ready(function (){
   

    $("#declarer").click(function () {
        
        /*document.getElementById("declarant").style.visibility = "visible";
        document.getElementById("declaration").style.visibility = "hidden";
        document.getElementById("naissance").style.visibility = "hidden";
        document.getElementById("mere").style.visibility = "hidden";
        document.getElementById("pere").style.visibility = "hidden";
        //document.getElementById("last").style.visibility = "visible";
        $("#").removeAttr('href').off('click');*/
        $("#declarant").css('display', 'block');
        $("#declaration").css('display', 'none');
        $("#naissance").css('display', 'none');
        $("#mere").css('display', 'none');
        $("#pere").css('display', 'none');
    });
   
   
}
 );
