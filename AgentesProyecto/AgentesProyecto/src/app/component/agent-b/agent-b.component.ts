import { Component, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-agent-b',
  templateUrl: './agent-b.component.html',
  styleUrls: ['./agent-b.component.css']
})
export class AgentBComponent {
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
    this.http.post<String>('/AgentB',strlist).subscribe(data=>{
      this.result1.nativeElement.style.cols = data.length + 12;
      this.result1.nativeElement.value = "Resultado :" + data;
    },error=>{
      this.result1.nativeElement.value = "Resultado :" + error.error;
    })

  }

  exeFun2() {
    var str = this.intStair.nativeElement.value;
    this.http.get<any>('AgentB?arg='+str).subscribe(data=>{
      this.result2.nativeElement.style.height = str;
      this.result2.nativeElement.style.width = (str + 9) + 'px';
      this.result2.nativeElement.value = data.result;
    },error=>{
      console.log(error)
      this.result2.nativeElement.value = "Resultado :" + error.error;
    })
  }
}
