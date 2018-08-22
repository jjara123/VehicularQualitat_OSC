window.onload = function () {

    DatosPoliza(1);

}


//Modelo Vehiculo:
function DatosPoliza(idpoliza) {

    $.ajax({
        type: "POST",
        url: "../Services/ListarDatosPoliza",
        data: "{idpoliza:'" + idpoliza + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: ListarDatosPoliza,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function ListarDatosPoliza(data) {

        for (i = 0; i < data.length; i++) {            
            dni = data[0].dni;
            nombre = data[0].nombre;
            sexo = data[0].sexo;
            nacionalidad = data[0].nacionalidad;
            ecivil = data[0].ecivil;
            fecnaci = data[0].fecnaci;
            email = data[0].email;
            telf = data[0].telf;
            celu = data[0].celu;
        }

        //$("#tipocontra_id").val(nropoliza);
       // $("#tipodoc_id").val(nropoliza);
        $("#dni_id").val(dni);
        $("#nombre_id").val(nombre);
        $("#nacionalidad_id").val(nacionalidad);
        $("#fecnaci_id").val(fecnaci);
        $("#email_id").val(email);
        $("#fono_id").val(telf);
        $("#cel_id").val(celu);
        $("#sexo_id").val(sexo);
  


}



//Error:
function OnError(data) {
    alert("Error 404...");
}
