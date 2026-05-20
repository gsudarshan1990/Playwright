import {Before, After,AfterAll,BeforeAll} from '@cucumber/cucumber'


BeforeAll(async()=>{

    console.log("===Before All===")
})

Before(async ()=>{

    console.log("=====Before =====")

})

After(async()=>{

    console.log("===After==")
})

AfterAll(()=>{

    console.log("==After All===")
})