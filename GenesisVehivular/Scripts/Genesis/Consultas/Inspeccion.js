
window.onload = function () {
        
}

//Lista inspeccion
function ListarInspeccion(iidinspeccion, idpoliza, placa, fechaini, fechafin, nombre, pagina, regporpag) {

    $.ajax({
        type: "POST",
        url: "../Services/ListarInspeccion",
        data: "{iidinspeccion:'" + iidinspeccion + "', idpoliza:'" + idpoliza + "', placa:'" + placa + "', fechaini:'" + fechaini + "', fechafin:'" + fechafin + "', nombre:'" + nombre + "', NroDePagina:'" + pagina + "', RegPorPag:'" + regporpag + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: ListarGrillaInspeccion,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError
    });
    
}

function ListarGrillaInspeccion(data) {
    //alert(1);

    var pagina = $("#Pagina").val();
    var select = $("#Pagina");
    var regporpag = "10";
    var TotalRegistros = "1";

    if (data.length < parseInt(regporpag)) {
        select.empty();
        for (i = 1; i == 1; i++) {
            select.append("<option value" + i + ">" + i + "</option>");
        }
    }
    else {
        select.empty();
        for (i = 1; i <= Math.ceil(parseInt(data[1].TotalRegistros) / parseInt(regporpag)) ; i++) {
            select.append("<option value" + i + ">" + i + "</option>");
        }
    }

    $("#Pagina").val(pagina);


    var tabla = $("#GridListar");
    tabla.empty();
    tabla.append("<thead class=bg-blues>"+
                "<tr>"+
                "<td>Nro. Inspección</td>"+
                "<td>Nro. Poli</td>"+
                "<td>Contratante</td>"+                
                "<td>Placa</td>" +                
                "<td>Fecha Registro</td>"+
                "<td>Fecha Programación</td>"+
                "<td>Marca</td>"+
                "<td>Modelo</td>"+
                "<td>Estado</td>" +
                "<td></td>" +
                "</tr>"+
                "</thead>");    
    

    if (data.length > 0)
    {
        tabla.append("<tbody>")
        for (i = 0; i < data.length; i++) {
            tabla.append(
                        "<tr>" +
                        "<td>" + data[i].iidinspeccion + "</td>" +
                        "<td>" + data[i].idpoliza + "</td>" +
                        "<td>" + data[i].Persona + "</td>" +
                        "<td>" + data[i].vplaca + "</td>" +
                        "<td>" + data[i].dtfec_hora_registro + "</td>" +
                        "<td>" + data[i].dfecha + "</td>" +
                        "<td>" + data[i].Marca + "</td>" +
                        "<td>" + data[i].Modelo + "</td>" +
                        "<td>" + data[i].Estado + "</td>" +
                        "<td><input type=button onclick = Link('" + data[i].iidinspeccion + "')  value=Seleccionar class=btn_customer btn-secondary/></td>" +
                        
                        "</tr>");                            
        }               
        tabla.append("</tbody>")
        

      

    }
    else
    {        
        tabla.append("<tbody>")        
        tabla.append(
                        "<center>" +
                        "No hay registro(s) selecionado(s) por los criterios de busqueda" +
                        "</center>");
       tabla.append("</tbody>")
    }
    
}

//Link con el metodo POST
function Link(idinspeccion) {
    //window.location = "../inspeccion/registroinspeccion?alarmid=" + alarmid;
    alert(idinspeccion);
    window.location = "../inspeccion/registroinspeccion";
    //$.redirect(surl,
    //{
    //    alarmhistoryid: alarmid, evento: even
    //}, "post", "");
}
function ListarGrilla() {

    var iidinspeccion = $("#idinspeccion").val();
    var idpoliza = $("#idpoliza").val();
    var placa = $("#placa").val();
    var fechaini = $("#fechaini").val();
    var fechafin = $("#fechafin").val();
    var nombre = $("#contratante").val();
    var pagina = $("#Pagina").val();
    var regporpag = "10";

    ListarInspeccion(iidinspeccion, idpoliza, placa, fechaini, fechafin, nombre, pagina, regporpag);

}

$("#btnBuscar").click(function () {

    ListarGrilla();

});

$("#btnLimpiar").click(function () {

    $("#idinspeccion").val('');
    $("#idpoliza").val('');
    $("#placa").val('');
    $("#fechaini").val('');
    $("#fechafin").val('');
    $("#contratante").val('');

});


$("select[name=Pagina]").change(function () {
    
    ListarGrilla();
    
});


$("#Anterior").click(function () {
    c = $("#Pagina").val();
    c = parseInt(c) - 1;
    if (c > 0) {
        $("#Pagina").val(c);

        ListarGrilla();
    }
    else
    {
        c = 1;
    }
    
    
});

$("#Siguiente").click(function () {
    c = $("#Pagina").val();
    c = parseInt(c) + 1;
    
    $("#Pagina").val(c);
    ListarGrilla();

});



//Error:
function OnError(data) {
    alert("Error 404...");    
}
