package com.example.poin;

import com.example.poin.config.AppProperties;
		import org.springframework.boot.SpringApplication;
		import org.springframework.boot.autoconfigure.SpringBootApplication;
		import org.springframework.boot.context.properties.EnableConfigurationProperties;

@SpringBootApplication
@EnableConfigurationProperties(AppProperties.class)
public class PoinApplication {

	public static void main(String[] args) {
		SpringApplication.run(PoinApplication.class, args);
	}
}
