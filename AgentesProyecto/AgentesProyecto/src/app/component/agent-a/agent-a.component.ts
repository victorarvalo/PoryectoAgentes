import { Component, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-agent-a',
  templateUrl: './agent-a.component.html',
  styleUrls: ['./agent-a.component.css']
})
export class AgentAComponent {

  /* the input reference */
  @ViewChild('inputNumbers')  inputNumbers!: ElementRef;  
  @ViewChild('numberList')  numberList!: ElementRef;
  @ViewChild('result1')  result1!: ElementRef;  
  @ViewChild('intStair')  intStair!: ElementRef;
  @ViewChild('result2')  result2!: ElementRef;
  constructor(private http: HttpClient){

  }

  getNumbers(){
    var str = this.inputNumbers.nativeElement.value
    str = str.replaceAll("\n",",");
    if(str.slice(-1)==","){str = str.slice(0, -1);}
    this.numberList.nativeElement.value = str
  }

  exeFun1() {
    var str = this.numberList.nativeElement.value;
    var strlist = str.split(",");
    this.http.post<String>('/AgentA',strlist).subscribe(data=>{
      this.result1.nativeElement.style.cols = data.length + 12;
      this.result1.nativeElement.value = "Resultado :" + data;
    },error=>{
      this.result1.nativeElement.value = "Resultado :" + error.error;
    })

  }

  exeFun2() {
    var str = this.intStair.nativeElement.value;
    this.http.get<any>('AgentA?arg='+str).subscribe(data=>{
      this.result2.nativeElement.style.height = str;
      var columsn = Number(str) + 30;
      this.result2.nativeElement.cols = columsn;
      this.result2.nativeElement.value = data.result;
    },error=>{
      console.log(error)
      this.result2.nativeElement.value = "Resultado :" + error.error;
    })
  }

}
