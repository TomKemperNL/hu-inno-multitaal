package nl.hu.ict.inno.hellojava;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {


    @GetMapping("/java")
    public String sayHello() {
        return "Hello Java!";
    }
}
