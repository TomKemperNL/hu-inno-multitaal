package nl.hu.ict.inno.hellojava;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.client.RestTemplate;

@RestController
public class HelloController {

    private RestTemplate restTemplate = new RestTemplate();

    @GetMapping("/java")
    public String sayHello() {
        return "Hello Java!";
    }

    @GetMapping("/net")
    public String sayHelloNet() {
        return restTemplate.getForObject("http://localhost:5269/net", String.class);
    }
}
