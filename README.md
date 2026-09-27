# 쉽게 배우는 C# 프로그래밍 3판 - 스터디

> ### 그냥 샀음..😅 근데 초반부 조금 읽어보니 쉽긴 쉬운 것 같다. 😆
> 그리고 책 종료 후 약간 초기 목표 설정이 생겼다..
> 간단하지만 유용한 윈도우 유틸리티 하나를 만들어보는 것으로...😅
>
> 다른 리포지토리에서는 전부 예제를 작성하고 실행해봤는데,
>
> **2026/06/19 현재...**
>
> 이 리포지토리에는 13, 14장만 남기고,  sln->slnx 정도로만 바꿨다.
>
> 책을 한번 읽고 중고로 판매한 상태다 보니... 다시 생각이 안나네 😂😂😂





## 책 정보

* 저자: 윤인성

* 판매처
    * yes24
        * https://www.yes24.com/product/goods/140839248

    * 교보문고
        * https://product.kyobobook.co.kr/detail/S000215079084

    * 알라딘
        * https://www.aladin.co.kr/shop/wproduct.aspx?ItemId=354735344


* 출판사 소개 페이지 (예제 소스 있음)
    * https://www.hanbit.co.kr/store/books/look.php?p_code=B6185498700
    * 공식 Github는 없음

## 목차

### 01. C# 프로그래밍 첫 걸음

### 02. 기본 문법

### 03. 조건문

### 04. 반복문

### 05. 클래스 기본

### 06. 메서드

### 07. 상속과 다형성

### 08. 클래스 심화

### 09. 인터페이스

### 10. 예외 처리

### 11. 델리게이터와 람다

### 12. Linq

### 13. [도서 관리 프로그램](chap13)

### 14. [인공지능 챗봇 프로그램](chap14)





## .NET 관련 링크

* .NET 설명서
    * https://learn.microsoft.com/ko-kr/dotnet/fundamentals/
* SDK 설명서
    * https://learn.microsoft.com/ko-kr/dotnet/core/sdk
* 릴리스 정보
    * 8.0: https://github.com/dotnet/core/tree/main/release-notes/8.0
    * 9.0: https://github.com/dotnet/core/tree/main/release-notes/9.0
    * 10.0: https://github.com/dotnet/core/tree/main/release-notes/10.0
* 자습서
    * https://learn.microsoft.com/ko-kr/dotnet/core/tutorials/





## 디펜던시 관리자 (NuGet)

NuGet은 .NET SDK에 포함되어있다.

테스트 프로젝트를 만들 때도, MSBuild나 xUnit 프로젝트로 별도로 만들 때, 그냥 디펜던시가 추가되고, 특별한 라이브러리를 추가할 일도 없을 것 같아서, 따로 디펜던시 관리 관련해서는 따로 할 일이 없을 것 같다.

### 라이브러리 업데이트

**권장 방법**: `dotnet-outdated-tool` 사용 **(일괄 업데이트)**

```sh
# dotnet-outdated-tool 설치 (최초 1회)
dotnet tool install --global dotnet-outdated-tool

# (선택) 설치된 도구 자체 업데이트
dotnet tool update --global dotnet-outdated-tool

# 솔루션 전체의 패키지를 최신 버전으로 자동 업데이트
dotnet outdated -u

# 업데이트 후 검증
dotnet test
```



**대안**: 기본 dotnet CLI 사용 **(개별확인 후 업데이트)**

```sh
# 업데이트 가능한 패키지 확인
dotnet list package --outdated

# 개별 패키지 업데이트 (현재 폴더의 프로젝트 1개 기준)
dotnet add package <패키지명>

# 여러 프로젝트가 있는 솔루션이라면 csproj를 명시하는 방식 권장
dotnet add <경로/프로젝트.csproj> package <패키지명>
```

**GUI 방법**: Visual Studio나 Rider의 NuGet 패키지 관리 UI를 사용하면 업데이트 가능한 패키지를 한눈에 보고 선택적으로 업데이트할 수 있다.

