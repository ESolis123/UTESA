/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package analizadorlexico;

import java.io.File;

/**
 *
 * @author Enrique Solis
 */
public class Principal {
    public static void main(String[] args) {
        String ruta = "C:/Users/Enrique Solis/OneDrive/Escritorio/UTESA/2-2021/1-Compiladores/Primer parcial/Tareas/Semana 2/AnalizadorLexico/AnalizadorLexico/src/analizadorlexico/Lexer.flex";
        generarLexer(ruta);
    }
    
    public static void generarLexer(String ruta){
        File archivo = new File(ruta);
        JFlex.Main.generate(archivo);
    }
}
