# _DevNcore Study_

- [ ] 체인 메서드
- [ ] Google  OAuth2 연동 클라이언트 ID 인증키 받기
- [ ] Google 로그인 연동 방법정리 및 구조파악 https://github.com/devncore/blazor-authentication 
- [ ] API Method 생성하기 
- [ ] DB Schema 활용하기
- [ ] Blazor Injecttion 
- [ ] React-Router-Dom


### Method Chaining 메소드 체이닝이란?
- 메소드가 객체를 반환하는 형태로 작성
- 한 문장에서 메소드 호출을 이어나갈 수 있다
- 코드를 읽기 쉽고 단순하게 만든다.
- 자신도 모르게 이미 체인 메서드를 사용하고 있다. EX) Linq 
</br>

### OAuth 2.0 클라이언트 ID 인증키 받는방법
- https://console.cloud.google.com/ 로그인
- 상단에 프로젝트 선택, 없다면 프로젝트 생성
- OAuth 동의화면 메뉴에서 화면만들기, 앱프로젝트명과 Email 주소 등록후 저장
- OAuth 앱 구성 등록 방식 User Type 은 외부 선택 후 저장 
- 사용자 인증 정보메뉴에서 사용자 인증 정보 만들기 클릭, OAuth 클라이언트 ID 클릭
- OAuth 애플리케이션 유형은 데스크톱 앱으로 우선 설정
- OAuth 클라이언트 ID 발급 완료
</br>

### Database Schema 란?
- 데이터베이스 개체에 대한 네임스페이스
- 스키마의 기본값은 dbo
- DB에 존재하는 스키마 정보 조회, 해당하는 테이블의 스키마 조회 가능
- 스키마를 생성하고 생성한 스키마를 UserId에 맵핑하여 사용
- 유저에 스키마가 맵핑 되었다면 테이블, 프로시저 생성시 기본적으로 맵핑된 스키마로 생성됨
</br>

### React Router Dom 이란?
   - 페이지의 로딩 없이 페이지에 필요한 컴포넌트를 불러와 렌더링 하여 보여주는것
   - React는 SPA 방식이기 때문에 해당 요청에 맞는 컴포넌트만 라우팅하여 부분적으로 렌더링 해야함
</br>

### Blazor Injection 이란?

### Scaffolding 이란?
   - MVC 에서 자주 사용되는 코드를 프레임워크 템플릿으로부터 자동으로 생성해 주는 기능을 MVC Scaffold 라고 한다.
   - Scaffold 로 자동 생성된것을 개발자가 부분 수정하여 필요한 기능을 쉽게 구현할 수 있다.

